import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-pokemon',
  templateUrl: './pokemon.component.html',
  styleUrls: ['./pokemon.component.css']
})
export class PokemonComponent implements OnInit {
  sub: any;
  id: any;
  data;
  constructor(
    private http: HttpClient,
    private route: ActivatedRoute) { }

  ngOnInit(): void {
    //Get page number parameter
    this.sub = this.route.params.subscribe(params => {
      this.id = +params['id'];
    });

    //Get data from pokemon api
    var url: string = "https://pokeapi.co/api/v2/pokemon/" + this.id;
    this.http.get<any>(url).subscribe(data => {
      this.data = data;
    }, error => {
      window.location.href= '/';
    })
  }

}
