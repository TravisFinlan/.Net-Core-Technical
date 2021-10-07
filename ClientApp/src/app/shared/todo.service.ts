import { Injectable } from '@angular/core';
import { ToDo } from './todo.model';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})

export class ToDoService {
  constructor(private http: HttpClient) {
  }

  //readonly _baseUrl = "https://localhost:44336/api/ToDo";
  readonly _baseUrl = window.location.origin + "/api/ToDo";

  formData: ToDo = new ToDo();
  list: ToDo[] = [];

  postToDo() {
    return this.http.post(this._baseUrl, this.formData);
  }

  putToDo() {
    return this.http.put(`${this._baseUrl}/${this.formData.id}`, this.formData);
  }

  deleteToDo(id: number) {
    return this.http.delete(`${this._baseUrl}/${id}`);
  }

  refreshList() {
    this.http.get(this._baseUrl)
      .toPromise()
      .then(res => this.list = res as ToDo[]);
  }
}
