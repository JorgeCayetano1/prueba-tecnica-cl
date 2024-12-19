export interface HttpRequest<T> {
  success: boolean;
  message: string;
  output: T;
  errors: string[] | null;
}
