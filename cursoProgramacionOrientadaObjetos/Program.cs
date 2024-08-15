
// Creando nuevo objeto para superman
var superman = new SuperHeroe();

superman.Id = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;
superman.SuperPoderes = new [] {"vision de rayos x", "Volar", "Super Fuerza", "Ojos rayos lazer"};

// Creando nuevo objeto para Batman
var batman = new SuperHeroe();

batman.Id = 2;
batman.Nombre = "Batman";
batman.IdentidadSecreta = "Bruce Wayne";
batman.Ciudad = "Gotham";
batman.PuedeVolar= false;
batman.SuperPoderes = new [] {"inteligencia superior", "Habilidades de detective", "Artes marciales", "Tenologia avanzada"};

// Creando nuevo objeto para Wonder woman
var wonderWoman = new SuperHeroe();

wonderWoman.Id = 3;
wonderWoman.Nombre= "Wonder Woman";
wonderWoman.IdentidadSecreta= "Diana Prince";
wonderWoman.Ciudad= "Themyscira";
wonderWoman.PuedeVolar = true;
wonderWoman.SuperPoderes= new [] {"Super Fuerza", "Inmortalidad", "Habilidad con el lazo de la verdad", "Velocidad"};


class SuperHeroe { 
  public int Id;
  public string Nombre;
  public string IdentidadSecreta;
  public string Ciudad;
  public string [] SuperPoderes;
  public bool PuedeVolar;
}