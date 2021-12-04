let x_vals = []
let y_vals = []

let a, b, c, d

const leatningRate = 0.2
const optimizer = tf.train.adam(leatningRate)

function setup(){
     a = tf.variable(tf.scalar(random(-1, 1)))
     b = tf.variable(tf.scalar(random(-1, 1)))
     c = tf.variable(tf.scalar(random(-1, 1)))
     d = tf.variable(tf.scalar(random(-1, 1)))

    let response = await fetch("Forecast/Forecast", {
        method: "POST",
        headers: { "Accept": "application/json", "Content-Type": "application/json" },
        body: JSON.stringify({ id: paramValue })
    });
    if (response.ok === true) {
        const data = await response.json()
        
    }

    fit()
}

function loss(predict, labels){
    return predict.sub(labels).square().mean()
}

function predict(x){
      const xs = tf.tensor1d(x)

      const ys = xs.pow(tf.scalar(3)).mul(a)
                   .add(xs.square().mul(b))
                   .add(xs.mul(c))
                   .add(d)
      return ys
}

function fit(){
      tf.tidy(() => {
          if (x_vals.length > 0){
            const ys = tf.tensor1d(y_vals)
            optimizer.minimize(() => loss(predict(x_vals), ys))
          }
        })

      background(0)

      stroke(255)
      strokeWeight(8)
      for (let i = 0; i < x_vals.length; i++){
        let px = map(x_vals[i], -1, 1, 0, width)
        let py = map(y_vals[i], -1, 1, height, 0)
        point(px, py)
      }


      const curveX = []
      for (let x = -1; x < 1.01; x+=0.05){
        curveX.push(x)
      }

      const ys = tf.tidy(() => predict(curveX))
      let curveY = ys.dataSync()
      ys.dispose()

      beginShape()
      noFill()
      stroke(255)
      strokeWeight(2)
      for (let i = 0; i < curveX.length; i++){
        let x = map(curveX[i], -1, 1, 0, width)
        let y = map(curveY[i], -1, 1, height, 0)
        vertex(x, y)
      }
      endShape()
}