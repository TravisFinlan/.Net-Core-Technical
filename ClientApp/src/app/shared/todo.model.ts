export class ToDo {
  id: number;
  description: string;
  isComplete: boolean;

  constructor() {
    this.id = 0;
    this.description = "";
    this.isComplete = false;
  }
}
