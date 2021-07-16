import { Component } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'Web';
  welcome = '';
  mode = environment.production ? 'Produkcja' : 'Testówka';

  constructor(private http: HttpClient) {}

  ngOnInit() {
    let httpOptions = {
      headers: new HttpHeaders({ 'Content-Type': 'application/json' }),
      responseType: 'text' as 'json',
    };
    this.http
      .get<string>(`${environment.url}Test/Hello`, httpOptions)
      .subscribe((x) => (this.welcome = x));
  }
}
