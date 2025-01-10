using Microsoft.AspNetCore.Mvc;
using Student_List.Models;
using Student_List.services; // This allows us to add our apiController

namespace Student_List.Controllers
{
    [ApiController] // This tells the file to read this as an API controller
    [Route("[controller]")] // removing the api/ as we no longer need to type it in our url.
    public class StudentListController : ControllerBase
    {
        // We are creating an empty reference to our Services
       private readonly StudentListServices _studentListServices;

        // The Constructor runs first when the api is called
        // Web API version of void start
        public StudentListController(StudentListServices studentListServices)
        {
          _studentListServices = studentListServices;
        }



        [HttpGet] // Use HttpGet to request Information or "Get info"
        [Route("FetchStudentList")]
        public List<StudentModel> GetStudents()
        {
            return _studentListServices.GetStudents();
        }
        

        [HttpPost] // Use HttpPost for adding information in the backend
        [Route("AddStudent/{studentToAdd}")] // To pass data through our routes, we add /{parameter}

        public List<StudentModel> AddToStudentList(string studentToAdd)
        {

            return _studentListServices.AddToStudentList(studentToAdd);
        }


        [HttpDelete] // Use HttpDelete When Removing Information for our data
        [Route("RemoveStudent/{studentToRemove}")]

        public List<StudentModel> RemoveFromStudentList(string studentToRemove)
        {
            return _studentListServices.RemoveFromStudentList(studentToRemove);
        }


        [HttpPut]
        [Route("EditStudent/{studentToEdit}/{newStudentName}")]

        public List<StudentModel> EditStudentFromList(string studentToEdit, string newStudentName)
        {
            // We are going to find the index at which studentToEdit exists and then change the value of that index.
           
            return _studentListServices.EditStudentFromList(studentToEdit, newStudentName);
        }
    }    
}