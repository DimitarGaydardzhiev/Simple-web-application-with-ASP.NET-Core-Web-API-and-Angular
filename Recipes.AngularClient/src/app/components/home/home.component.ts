import { Component, OnInit } from '@angular/core';
import { Recipe } from 'src/app/models/recipe/recipe.model';
import { ItemService } from 'src/app/services/item.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html'
})
export class HomeComponent implements OnInit {
  public recipes: Recipe[] = [];

  constructor(private itemService: ItemService) { }

  ngOnInit(): void {
    this.itemService.getItems<Recipe[]>({ itemName: "recipe" }).subscribe(result => {
      this.recipes = result;
    })
  }
}
