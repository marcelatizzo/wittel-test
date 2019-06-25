import { Component } from '@angular/core';
@Component({
    selector: 'home',
    templateUrl: './app/component/home/home.html'
})
export class HomeComponent {
    title: string;
    constructor() {
        this.title = 'SPA';
    }
}