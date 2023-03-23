import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";

@Injectable()
export class ApiService {
    apiUrl: string = 'http://localhost:5079/'

    constructor(
        private http: HttpClient) {
    }

    get(path: string): Observable<any> {
        return this.http['get'](`${this.apiUrl}${path}`);
    }

    post(path: string, body: any): Observable<any> {
        return this.http['post'](`${this.apiUrl}${path}`, body);
    }
}