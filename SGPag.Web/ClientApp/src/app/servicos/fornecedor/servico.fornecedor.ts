import { Injectable, Inject } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Fornecedor } from "../../modelo/fornecedor";
//import { } from "";

@Injectable({
  providedIn: "root"
})

export class ServicoFornecedor {

  private baseURL: string;
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseURL = baseUrl;
  }
  get headers(): HttpHeaders {
    return new HttpHeaders().set('content-type', 'application/json; charset=UTF-8');
  }
  public cadastrarEmpresa(fornecedor: Fornecedor): Observable<Fornecedor> {
    return this.http.post<Fornecedor>(this.baseURL + "api/fornecedor", JSON.stringify(fornecedor), { headers: this.headers });
  }
  public obterTodos(): Observable<Fornecedor[]> {
    return this.http.get<Fornecedor[]>(this.baseURL + "api/fornecedor");
  }
}
