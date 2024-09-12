using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSAppUsingEF.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        [Required]
        public int PatientId { get; set; }
        [ForeignKey("PatientId")]

        public Patient Patient { get; set; }

        [Required]
        public int DoctorId { get; set; }

        [ForeignKey("Patient")]

        public Doctor Doctor { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public DateTime AppointmentDate { get; set; }
    }
}
