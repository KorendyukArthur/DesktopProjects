from flask import Flask

app = Flask(__name__)

@app.route("/")
def hello():
    return "Руд"

app.run(port='8000')

