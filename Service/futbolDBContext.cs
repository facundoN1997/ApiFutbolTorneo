using apiFutbol.model;
using Microsoft.EntityFrameworkCore;

namespace apiFutbol.Service
{
    public class FutbolDBContext : DbContext
    {
        public FutbolDBContext(DbContextOptions<FutbolDBContext> options) : base(options)
        {

        }

        //INICIALIZÓ LA BASE DE DATOS CON UNOS CIERTOS REGISTROS POR DEFECTO
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //AGREGO DATOS INICIALES A LA TABLA DE EQUIPOS
            var equipo1 = new EquipoFutbol() { id = 1, nombre = "Arsenal", color = "celeste" };
            var equipo2 = new EquipoFutbol() { id = 2, nombre = "Independiente", color = "rojo" };
            var equipo3 = new EquipoFutbol() { id = 3, nombre = "Banfield", color = "verde y rojo" };
            var equipo4 = new EquipoFutbol() { id = 4, nombre = "Tigre", color = "rojo y azul" };
            var equipo5 = new EquipoFutbol() { id = 5, nombre = "Racing", color = "celeste y blanco" };
            var equipo6 = new EquipoFutbol() { id = 6, nombre = "River", color = "rojo y blanco" };


            modelBuilder.Entity<EquipoFutbol>().HasData(new EquipoFutbol[] {
                equipo1,
                equipo2,
                equipo3,
                equipo4,
                equipo5,
                equipo6

            });


            //AGREGO DATOS INICIALES A LA TABLA DE JUGADORAS
            //JUGADORAS DE ARSENAL
            var jugadora1 = new jugadorFutbol() { id = 1, dni = 40640921, nombre = "Carla", apellido = "Suarez", equipoJugando = "Arsenal" };
            var jugadora2 = new jugadorFutbol() { id = 2, dni = 41640822, nombre = "Martina", apellido = "Gutierrez", equipoJugando = "Arsenal" };
            var jugadora3 = new jugadorFutbol() { id = 3, dni = 42680923, nombre = "Marta", apellido = "Souza", equipoJugando = "Arsenal" };
            var jugadora4 = new jugadorFutbol() { id = 4, dni = 43640924, nombre = "Natalia", apellido = "Perez", equipoJugando = "Arsenal" };
            var jugadora5 = new jugadorFutbol() { id = 5, dni = 44640925, nombre = "Rocio", apellido = "Alvarez", equipoJugando = "Arsenal" };
            var jugadora6 = new jugadorFutbol() { id = 6, dni = 45640926, nombre = "Micaela", apellido = "Fole", equipoJugando = "Arsenal" };
            var jugadora7 = new jugadorFutbol() { id = 7, dni = 46640927, nombre = "Antonela", apellido = "Gonzalez", equipoJugando = "Arsenal" };
            var jugadora8 = new jugadorFutbol() { id = 8, dni = 47640928, nombre = "Beatriz", apellido = "Ramirez", equipoJugando = "Arsenal" };
            var jugadora9 = new jugadorFutbol() { id = 9, dni = 48640929, nombre = "Gabriela", apellido = "Jacinto", equipoJugando = "Arsenal" };
            var jugadora10 = new jugadorFutbol() { id = 10, dni = 49640928, nombre = "Tamara", apellido = "Suarez", equipoJugando = "Arsenal" };
            var jugadora11 = new jugadorFutbol() { id = 11, dni = 41040929, nombre = "Belen", apellido = "Martinez", equipoJugando = "Arsenal" };


            //JUGADORAS DE INDEPENDIENTE
            var jugadora12 = new jugadorFutbol() { id = 12, dni = 41140922, nombre = "Marina", apellido = "Perez", equipoJugando = "Independiente" };
            var jugadora13 = new jugadorFutbol() { id = 13, dni = 94120923, nombre = "Martina", apellido = "Alvarez", equipoJugando = "Independiente" };
            var jugadora14 = new jugadorFutbol() { id = 14, dni = 41340924, nombre = "Eugenia", apellido = "Souza", equipoJugando = "Independiente" };
            var jugadora15 = new jugadorFutbol() { id = 15, dni = 41440925, nombre = "Oriana", apellido = "Gonzalez", equipoJugando = "Independiente" };
            var jugadora16 = new jugadorFutbol() { id = 16, dni = 41540926, nombre = "Marina", apellido = "Alvarez", equipoJugando = "Independiente" };
            var jugadora17 = new jugadorFutbol() { id = 17, dni = 41640977, nombre = "Marta", apellido = "Angel", equipoJugando = "Independiente" };
            var jugadora18 = new jugadorFutbol() { id = 18, dni = 41740928, nombre = "Romina", apellido = "Maritini", equipoJugando = "Independiente" };
            var jugadora19 = new jugadorFutbol() { id = 19, dni = 41940929, nombre = "Juliana", apellido = "Capelletti", equipoJugando = "Independiente" };

            //JUGADORAS DE BANFIELD
            var jugadora20 = new jugadorFutbol() { id = 20, dni = 42040928, nombre = "Martina", apellido = "Suarez", equipoJugando = "Banfield" };
            var jugadora21 = new jugadorFutbol() { id = 21, dni = 42140929, nombre = "Cecilia", apellido = "Gutierrez", equipoJugando = "Banfield" };
            var jugadora22 = new jugadorFutbol() { id = 22, dni = 42240921, nombre = "Marta", apellido = "Espinonza", equipoJugando = "Banfield" };
            var jugadora23 = new jugadorFutbol() { id = 23, dni = 42340922, nombre = "Julie", apellido = "Tarantini", equipoJugando = "Banfield" };
            var jugadora24 = new jugadorFutbol() { id = 24, dni = 42440923, nombre = "Rocio", apellido = "Alvarez", equipoJugando = "Banfield" };
            var jugadora25 = new jugadorFutbol() { id = 25, dni = 42540924, nombre = "Micaela", apellido = "Fole", equipoJugando = "Banfield" };
            var jugadora26 = new jugadorFutbol() { id = 26, dni = 42640965, nombre = "Antonela", apellido = "Gonzalez", equipoJugando = "Banfield" };
            var jugadora27 = new jugadorFutbol() { id = 27, dni = 42740926, nombre = "Abril", apellido = "Ramirez", equipoJugando = "Banfield" };
            var jugadora28 = new jugadorFutbol() { id = 28, dni = 42840927, nombre = "Gabriela", apellido = "Jacinto", equipoJugando = "Banfield" };
            var jugadora29 = new jugadorFutbol() { id = 29, dni = 42940928, nombre = "Tamara", apellido = "Suarez", equipoJugando = "Banfield" };
            var jugadora30 = new jugadorFutbol() { id = 30, dni = 43040929, nombre = "Belen", apellido = "Martinez", equipoJugando = "Banfield" };
            var jugadora31 = new jugadorFutbol() { id = 31, dni = 43140900, nombre = "Violeta", apellido = "Espinoza", equipoJugando = "Banfield" };


            //JUGADORAS DE RACING
            var jugadora32 = new jugadorFutbol() { id = 32, dni = 43240921, nombre = "Catalina", apellido = "Godoy", equipoJugando = "Racing" };
            var jugadora33 = new jugadorFutbol() { id = 33, dni = 43340922, nombre = "Martina", apellido = "Perez", equipoJugando = "Racing" };
            var jugadora34 = new jugadorFutbol() { id = 34, dni = 34640923, nombre = "Marta", apellido = "Alvarez", equipoJugando = "Racing" };
            var jugadora35 = new jugadorFutbol() { id = 35, dni = 43540924, nombre = "Natalia", apellido = "Perez", equipoJugando = "Racing" };
            var jugadora36 = new jugadorFutbol() { id = 36, dni = 43640925, nombre = "Guadalupe", apellido = "Garcia", equipoJugando = "Racing" };
            var jugadora37 = new jugadorFutbol() { id = 37, dni = 43740926, nombre = "Oriana", apellido = "Fole", equipoJugando = "Racing" };
            var jugadora38 = new jugadorFutbol() { id = 38, dni = 43840927, nombre = "Mariana", apellido = "Gonzalez", equipoJugando = "Racing" };
            var jugadora39 = new jugadorFutbol() { id = 39, dni = 43940928, nombre = "Patricia", apellido = "Naupari", equipoJugando = "Racing" };
            var jugadora40 = new jugadorFutbol() { id = 40, dni = 44040929, nombre = "Nicole", apellido = "Jacinto", equipoJugando = "Racing" };


            //JUGADORAS DE RIVER
            var jugadora41 = new jugadorFutbol() { id = 41, dni = 44140920, nombre = "Carla", apellido = "Suarez", equipoJugando = "River" };
            var jugadora42 = new jugadorFutbol() { id = 42, dni = 44240920, nombre = "Martina", apellido = "Gutierrez", equipoJugando = "River" };
            var jugadora43 = new jugadorFutbol() { id = 43, dni = 44340920, nombre = "Marta", apellido = "Souza", equipoJugando = "River" };
            var jugadora44 = new jugadorFutbol() { id = 44, dni = 44440921, nombre = "Natalia", apellido = "Perez", equipoJugando = "River" };
            var jugadora45 = new jugadorFutbol() { id = 45, dni = 44540922, nombre = "Rocio", apellido = "Alvarez", equipoJugando = "River" };
            var jugadora46 = new jugadorFutbol() { id = 46, dni = 44640923, nombre = "Micaela", apellido = "Fole", equipoJugando = "River" };
            var jugadora47 = new jugadorFutbol() { id = 47, dni = 44740924, nombre = "Antonela", apellido = "Gonzalez", equipoJugando = "River" };
            var jugadora48 = new jugadorFutbol() { id = 48, dni = 44840925, nombre = "Diana", apellido = "Ramirez", equipoJugando = "River" };
            var jugadora49 = new jugadorFutbol() { id = 49, dni = 44940927, nombre = "Gabriela", apellido = "Jacinto", equipoJugando = "River" };
            var jugadora50 = new jugadorFutbol() { id = 50, dni = 45040956, nombre = "Tamara", apellido = "Suarez", equipoJugando = "River" };
            var jugadora51 = new jugadorFutbol() { id = 51, dni = 45140929, nombre = "Belen", apellido = "Martinez", equipoJugando = "River" };


            modelBuilder.Entity<jugadorFutbol>().HasData(new jugadorFutbol[] {
                jugadora1,
                jugadora2,
                jugadora3,
                jugadora4,
                jugadora5,
                jugadora6,
                jugadora7,
                jugadora8,
                jugadora9,
                jugadora10,
                jugadora11,
                jugadora12,
                jugadora13,
                jugadora14,
                jugadora15,
                jugadora16,
                jugadora17,
                jugadora18,
                jugadora19,
                jugadora20,
                jugadora21,
                jugadora22,
                jugadora23,
                jugadora25,
                jugadora26,
                jugadora27,
                jugadora28,
                jugadora29,
                jugadora30,
                jugadora31,
                jugadora32,
                jugadora33,
                jugadora34,
                jugadora35,
                jugadora36,
                jugadora37,
                jugadora38,
                jugadora39,
                jugadora41,
                jugadora42,
                jugadora43,
                jugadora44,
                jugadora45,
                jugadora46,
                jugadora47,
                jugadora48,
                jugadora49,
                jugadora50,
                jugadora51

            });


            base.OnModelCreating(modelBuilder);

        }

        public DbSet<EquipoFutbol> EquipoFutbol { get; set; } = null!;
        public DbSet<jugadorFutbol> jugadorFutbol { get; set; } = null!;




    }
}
