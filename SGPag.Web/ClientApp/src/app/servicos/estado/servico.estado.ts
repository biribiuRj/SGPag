import { Injectable, Inject } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Estado } from "../../modelo/estado";
//import { } from "";

@Injectable({
  providedIn: "root"
})

export class ServicoEstado {

  private baseURL: string;
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseURL = baseUrl;
  }
  get headers(): HttpHeaders {
    return new HttpHeaders().set('content-type', 'application/json; charset=UTF-8');
  }
  public cadastrarEstado(estado: Estado): Observable<Estado> {
    return this.http.post<Estado>(this.baseURL + "api/estado", JSON.stringify(estado), { headers: this.headers });
  }
  public obterTodos(): Observable<Estado[]> {
    return this.http.get<Estado[]>(this.baseURL + "api/estado");
  }
}
