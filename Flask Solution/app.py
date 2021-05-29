from flask import Flask, redirect, url_for, request, render_template
from flask_paginate import Pagination, get_page_parameter
import requests

app = Flask(__name__)


@app.route('/pokemon-directory')
def directory():
    page = request.args.get(get_page_parameter(), type=int, default=1)
    resp = requests.get("https://pokeapi.co/api/v2/pokemon?offset=" + str((page - 1) * 150) + "&limit=150").json()
    print("TEST: "+ ("https://pokeapi.co/api/v2/pokemon?offset=" + str((page - 1) * 150) + "&limit=150"))
    directory = resp["results"]

    pagination = Pagination(page=page,
                            total=resp['count'],
                            offset=page * 150,
                            per_page=150,
                            record_name='pokemon_directory',
                            css_framework='bootstrap4')
    temp = directory
    directory = []
    for pokemon in temp:
        pokemon["url"] = pokemon["url"].replace("https://pokeapi.co/api/v2", "")
        directory.append(pokemon)

    return render_template("directory.html",
                           directory=directory,
                           pagination=pagination)


@app.route('/pokemon/<query>/')
@app.route('/pokemon/<query>')
def pokemon(query):
    resp = requests.get("https://pokeapi.co/api/v2/pokemon/" + query)
    if resp.status_code != 200:
        return redirect(url_for("directory"))
    return render_template("pokemon.html", data=resp.json())


@app.errorhandler(404)
def error(error): return redirect(url_for("directory"))


app.run()
