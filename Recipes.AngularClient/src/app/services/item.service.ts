import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { ApiService } from "./api.service";

@Injectable()
export class ItemService {
    constructor(
        private apiSerice: ApiService) {
    }

    getItems<T>(itemArgs: ItemArgs): Observable<T> {
        return this.apiSerice.get(`${itemArgs.itemName}/index`) as Observable<T>;
    }
}

interface ItemArgs {
    itemName: string;
}