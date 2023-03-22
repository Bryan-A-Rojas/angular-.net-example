import { Component } from '@angular/core';
import { RandomNumberService } from './random-number.service';

@Component({
  selector: 'app-random-number',
  templateUrl: './random-number.component.html',
  styleUrls: ['./random-number.component.scss'],
})
export class RandomNumberComponent {
  randomNumber?: Number = undefined;

  constructor(private RandomNumberService: RandomNumberService) { }

  async ngOnInit() {
    const RandomNumberResponse = await this.RandomNumberService.sendRequest();

    console.log('On Init: ', RandomNumberResponse)

    this.randomNumber = 1;
  }

  async fetchRandomNumber() {
    const RandomNumberResponse = await this.RandomNumberService.sendRequest();

    console.log('On Click: ', RandomNumberResponse)

    this.randomNumber = 1;
  }
}
