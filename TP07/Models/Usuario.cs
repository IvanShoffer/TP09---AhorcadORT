namespace TP07.Models;
using Newtonsoft.Json;
public  class Usuario
{
    [JsonProperty]
    public string nombre;
    [JsonProperty]
    public  int cantidadIntentos;
}

