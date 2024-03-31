import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
@Injectable({
    providedIn: 'root'
})
export class EventService {
    constructor(private http: HttpClient) { }

    getEvents() {
        return this.http.get('https://localhost:44301/api/services/app/Event/GetEvents');
    }
}