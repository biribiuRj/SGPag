import { Injectable, Inject } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Empresa } from "../../modelo/empresa";
//import { } from "";

@Injectable({
  providedIn: "root"
})

export class ServicoEmpresa {

  private baseURL: string;
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseURL = baseUrl;
  }
  get headers(): HttpHeaders {
    return new HttpHeaders().set('content-type', 'application/json; charset=UTF-8');
  }
  public cadastrarEmpresa(empresa: Empresa): Observable<Empresa> {
    return this.http.post<Empresa>(this.baseURL + "api/empresa", JSON.stringify(empresa), { headers: this.headers });
  }
  public obterTodos(): Observable<Empresa[]> {
    return this.http.get<Empresa[]>(this.baseURL + "api/empresa");
  }
  public deletarEmpresa(empresa: Empresa): Observable<Empresa[]> {
    return this.http.get<Empresa[]>(this.baseURL + "api/empresa/deletar");
  }
}
