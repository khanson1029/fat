import { Component } from '@angular/core';
import { DisplayStringsClient } from '../web-api-client';

@Component({
  selector: 'app-displaystrings',
  templateUrl: './displaystrings.component.html',
  styleUrls: ['./displaystrings.component.css']
})
export class DisplaystringsComponent {
  public helloString = "";
  public randomStr = "";
  constructor(
    private client: DisplayStringsClient
  ) {}

  public getHello() {
    this.client.getHello().subscribe({
      next: result => this.helloString = result,
      error: error => console.error(error)
    });  
  }

  public getRandomStr(){
    this.client.getRand().subscribe({
      next:result=> this.randomStr = result,
      error:error=> console.error(error)
    });
  }
}
