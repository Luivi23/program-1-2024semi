﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistema_academico.Models {
    public class Matricula {
        [Key]
        public int idMatricula { get; set; }
        public int idAlumno { get; set; } //[fk_matricula_alumno]
        public DateTime fecha { get; set; }
        public String periodo { get; set; }
        //relacionar con la tabla alumnos
        [ForeignKey("idAlumno")]
        public Alumno? Alumno { get; set; }
    }
}
