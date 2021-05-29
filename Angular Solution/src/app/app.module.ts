import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { HeaderComponent } from './components/subviews/header/header.component';
import { FooterComponent } from './components/subviews/footer/footer.component';
import { DirectoryComponent } from './components/directory/directory.component';
import { PokemonComponent } from './components/pokemon/pokemon.component';

const routes: Routes = [
  { path: 'pokemon-directory/:page', component: DirectoryComponent },
  { path: 'pokemon/:id', component: PokemonComponent },
  {path: '**', redirectTo: '/pokemon-directory/1'}
];

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    DirectoryComponent,
    PokemonComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(routes),
    HttpClientModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
