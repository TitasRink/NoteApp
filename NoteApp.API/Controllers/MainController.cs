﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NoteApp.Bussness.Interfaces;
using NoteApp.Repository.DTO;

namespace NoteApp.API.Controllers
{
    [Route("api/Services")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly INoteService _noteService;
        private readonly ICategoryService _categoryService;
        
        public MainController(INoteService noteService, ICategoryService categoryService)
        {
            _noteService = noteService;
            _categoryService = categoryService;
        }

        [HttpPost("Create_note_and_mesage"), Authorize]
        public ActionResult Create([FromBody] NoteDTO note)
        {
            var result = _noteService.CreateNoteAndMessage(note.Name, note.Message, note.IdName);
            return Ok(result);
        }

        [HttpPost("Create_Category"), Authorize]
        public ActionResult Createcategory([FromBody] CategoryDTO category)
        {
            var result = _categoryService.CreateCategory(category.Name, category.UserNameId);
            return Ok(result);
        }

        [HttpPost("Remove_Note"), Authorize]
        public ActionResult RemoveNote([FromBody] NoteDTO note)
        {
            var result = _noteService.DeleteNote(note.Name, note.IdName);
            return Ok(result);
        }
        
        [HttpPost("Move_note_to_category"), Authorize]
        public ActionResult MoveNote([FromBody] CategoryDTO category)
        {
            var result = _noteService.MoveNoteToCategory(category.Name , category.UserNameId);
            return Ok(result);
        }

        [HttpPost("Update_Note"), Authorize]
        public ActionResult UpdateNote([FromBody] NoteDTO note)
        {
            var result = _noteService.UpdateNote(note.Name, note.Message);
            return Ok(result);
        }

        [HttpPost("Rename_category_name"), Authorize]
        public ActionResult UpdateCategory(CategoryDTO category)
        {
            var result = _categoryService.UpdateCategoryName(category.Name, category.UserNameId);
            return Ok(result);
        }

        [HttpPost("Remove_Category"), Authorize]
        public ActionResult RemoveCategory(CategoryDTO category)
        {
            var result = _categoryService.DeleteCategory(category.Name);
            return Ok(result);
        }

        [HttpPost("Find_all_Notes_by_name"), Authorize]
        public ActionResult FindNotesByName(NoteDTO note)
        {
            var result = _noteService.FilterByNote(note.IdName);
            return Ok(result);
        }

        [HttpGet("Find_Categories"), Authorize]
        public ActionResult FindAllCategoreys()
        {
            var result = _categoryService.FilterCategory();
            return Ok(result);
        }

        [HttpPost("Find_Notes_by_Category"), Authorize]
        public ActionResult FindNotesByNameCategory(CategoryDTO category)
        {
            var result = _noteService.FilterNoteByCategory(category.Name, category.UserNameId);
            return Ok(result);
        }

        [HttpPost("AddImg"), Authorize]
        public void ImgAdd(NoteDTO note)
        {
            _noteService.ImgAdd(note.Name, note.Data);
        }
    }
}
