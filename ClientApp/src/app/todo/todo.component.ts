import { Component, OnInit } from '@angular/core';
import { ToDo } from '../shared/todo.model';
import { ToDoService } from '../shared/todo.service';

@Component({
  selector: 'app-todo',
  templateUrl: './todo.component.html',
  styles: [
  ]
})
export class ToDoComponent implements OnInit {

  constructor(public service: ToDoService) { }

  ngOnInit(): void {
    this.service.refreshList();
  }

  populateForm(selectedRecord: ToDo) {
    this.service.formData = Object.assign({}, selectedRecord);
  }

  onDelete(id: number) {
    this.service.deleteToDo(id)
      .subscribe(
        res => {
          this.service.refreshList();
        },
        err => { console.log(err) }
      )
  }
} 
