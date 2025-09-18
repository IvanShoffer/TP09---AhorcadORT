namespace TP07.Models;
using Newtonsoft.Json;
public class Juego
{
    [JsonProperty]
    public List<Palabra> ListaPalabras;
    [JsonProperty]
    public List<Usuario> Jugadores;
    [JsonProperty]
    public  Usuario jugadorActual;

     private void LlenarListaPalabras()
    {
            
           ListaPalabras = new List<Palabra>();

    
    ListaPalabras.Add(new Palabra { Texto = "gato", Dificultad = 1 });
    ListaPalabras.Add(new Palabra { Texto = "casa", Dificultad = 1 });
    ListaPalabras.Add(new Palabra { Texto = "sol", Dificultad = 1 });
    ListaPalabras.Add(new Palabra { Texto = "perro", Dificultad = 1 });
    ListaPalabras.Add(new Palabra { Texto = "flor", Dificultad = 1 });
    ListaPalabras.Add(new Palabra { Texto = "pan", Dificultad = 1 });
    ListaPalabras.Add(new Palabra { Texto = "mar", Dificultad = 1 });
    ListaPalabras.Add(new Palabra { Texto = "luz", Dificultad = 1 });
    ListaPalabras.Add(new Palabra { Texto = "mesa", Dificultad = 1 });
    ListaPalabras.Add(new Palabra { Texto = "nube", Dificultad = 1 });

   
    ListaPalabras.Add(new Palabra { Texto = "camino", Dificultad = 2 });
    ListaPalabras.Add(new Palabra { Texto = "ventana", Dificultad = 2 });
    ListaPalabras.Add(new Palabra { Texto = "barco", Dificultad = 2 });
    ListaPalabras.Add(new Palabra { Texto = "zapato", Dificultad = 2 });
    ListaPalabras.Add(new Palabra { Texto = "bosque", Dificultad = 2 });
    ListaPalabras.Add(new Palabra { Texto = "cuadro", Dificultad = 2 });
    ListaPalabras.Add(new Palabra { Texto = "puente", Dificultad = 2 });
    ListaPalabras.Add(new Palabra { Texto = "caballo", Dificultad = 2 });
    ListaPalabras.Add(new Palabra { Texto = "reloj", Dificultad = 2 });
    ListaPalabras.Add(new Palabra { Texto = "campera", Dificultad = 2 });

    
    ListaPalabras.Add(new Palabra { Texto = "biblioteca", Dificultad = 3 });
    ListaPalabras.Add(new Palabra { Texto = "montaña", Dificultad = 3 });
    ListaPalabras.Add(new Palabra { Texto = "mariposa", Dificultad = 3 });
    ListaPalabras.Add(new Palabra { Texto = "escalera", Dificultad = 3 });
    ListaPalabras.Add(new Palabra { Texto = "tormenta", Dificultad = 3 });
    ListaPalabras.Add(new Palabra { Texto = "espejismo", Dificultad = 3 });
    ListaPalabras.Add(new Palabra { Texto = "carretera", Dificultad = 3 });
    ListaPalabras.Add(new Palabra { Texto = "murciélago", Dificultad = 3 });
    ListaPalabras.Add(new Palabra { Texto = "castillo", Dificultad = 3 });
    ListaPalabras.Add(new Palabra { Texto = "relámpago", Dificultad = 3 });

    
    ListaPalabras.Add(new Palabra { Texto = "paralelepípedo", Dificultad = 4 });
    ListaPalabras.Add(new Palabra { Texto = "electroencefalograma", Dificultad = 4 });
    ListaPalabras.Add(new Palabra { Texto = "otorrinolaringólogo", Dificultad = 4 });
    ListaPalabras.Add(new Palabra { Texto = "anticonstitucionalidad", Dificultad = 4 });
    ListaPalabras.Add(new Palabra { Texto = "inconstitucional", Dificultad = 4 });
    ListaPalabras.Add(new Palabra { Texto = "desafortunadamente", Dificultad = 4 });
    ListaPalabras.Add(new Palabra { Texto = "desproporcionadamente", Dificultad = 4 });
    ListaPalabras.Add(new Palabra { Texto = "electrodoméstico", Dificultad = 4 });
    ListaPalabras.Add(new Palabra { Texto = "desoxirribonucleico", Dificultad = 4 });
    ListaPalabras.Add(new Palabra { Texto = "hipopotomonstrosesquipedaliofobia", Dificultad = 4 });
}
public void InicializarJuego(string usuario, int dificultad)
{
        ListaPalabras = new List<Palabra>();
    Jugadores = new List<Usuario>();

  
    LlenarListaPalabras();

    
    
     jugadorActual = new Usuario();
    jugadorActual.nombre = usuario;
    jugadorActual.cantidadIntentos = 0;
}
private String CargarPalabra(int Dificultad)
{
    
    string palabraReturn="";
  foreach(Palabra palabra in ListaPalabras)
  {
    if(palabra.Dificultad== Dificultad)
   {
        palabraReturn=palabra.Texto;
        
   } 
  }
   return palabraReturn;
}
private void FinJuego(int intentos)
{
    
    jugadorActual.cantidadIntentos = intentos;
    Jugadores.Add(jugadorActual);
}
 private List<Usuario> DevolverListaUsuarios()
 {
    Jugadores.Sort((a, b) => a.cantidadIntentos.CompareTo(b.cantidadIntentos));
    return Jugadores;
 }


           
            
    
    
}
    
