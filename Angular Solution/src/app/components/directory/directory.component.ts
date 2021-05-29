import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-directory',
  templateUrl: './directory.component.html',
  styleUrls: ['./directory.component.css']
})
export class DirectoryComponent implements OnInit {
  directory: any;
  page : number;
  private sub: any;
  results;

  constructor(
    private http: HttpClient,
    private route: ActivatedRoute
  ) { }

  ngOnInit(): void {
    //Get page number parameter
    this.sub = this.route.params.subscribe(params => {
      this.page = +params['page'];
    });

    //Get data from pokemon api
    var url: string = "https://pokeapi.co/api/v2/pokemon?offset=" + ((this.page - 1) * 150) + "&limit=150";
    this.http.get<any>(url).subscribe(data => {
      this.directory = data;
      this.results = data['results'];
      //Check page number is not negative, otherwise return to start of directory
      if (this.page < 1) {
        window.location.href = "/pokemon-directory/1";
      //Check page number does not go over max listings, otherwise return to end of directory
      } else if ((this.page * 150 - 149) > this.directory['count']) {
        window.location.href = "/pokemon-directory/" + ((Math.floor(this.directory['count'] / 150)) + 1);
      }
    })
  }
}
