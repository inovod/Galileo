import { Directive , Input, EventEmitter, Output } from '@angular/core';
export type SortDirection = 'asc' | 'desc' | '';
// tslint:disable-next-line:object-literal-key-quotes
const rotate: {[key: string]: SortDirection} = { 'asc': 'desc', 'desc': '', '': 'asc' };
export interface SortEvent {
  column: string;
  direction: SortDirection;
}
@Directive({
  // tslint:disable-next-line:directive-selector
  selector: 'th[sortable]' ,
  // tslint:disable-next-line:no-host-metadata-property
  host: {
    '[class.asc]': 'direction === "asc"',
    '[class.desc]': 'direction === "desc"',
    '(click)': 'rotate()'
  }
})
export class SurtidoSortableDirective {
  @Input() sortable: string;
  @Input() direction: SortDirection = '';
  @Output() sort = new EventEmitter<SortEvent>();

  constructor() { }

  rotate() {
    this.direction = rotate[this.direction];
    this.sort.emit({column: this.sortable, direction: this.direction});
  }
}
