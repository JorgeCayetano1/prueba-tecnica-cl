export interface Paginator<T> {
  length: number;
  pageSize: number;
  data: T[];
}
