import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-reasons',
  templateUrl: './reasons.component.html'
})
export class ReasonsComponent {
  public http: HttpClient;
  public baseUrl: string;
  public reasons: Reason[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.http = http;
    this.baseUrl = baseUrl;
    this.http.get<Reason[]>(this.baseUrl + 'reasons').subscribe(result => {
      this.reasons = result;
    }, error => console.error(error));
  }

  public add() {
    var reason = {
      id: 0,
      description: '',
      createdOn: '',
      modifiedOn: ''
    };
    this.reasons.push(reason);
  }

  public save() {
    this.http.post<Reason[]>(this.baseUrl + 'reasons', this.reasons.slice(0)).subscribe(result => {
      //this.reasons = result;
    }, error => console.error(error));
  }
}

export interface Reason {
  id: number;
  description: string;
  createdOn: string;
  modifiedOn: string;
}
