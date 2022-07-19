using KellermanSoftware.CompareNetObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoteApp.Bussness.Services;
using NoteApp.Repository.Entities;

namespace NoteApp.Test
{
    [TestClass]
    public class NoteServiceTest
    {
        [TestMethod]
        public void CreateNewNoteWithMessage_EnteredValueEmpty_ReturnsFalse()
        {
            // Arrange
            NoteService note = new NoteService();
         
            // Act

            var actualEmpty = note.CreateNoteAndMessage("", "", "");
            var expected = new Result(false, "Fill up fields");
            var comparisonResult = new CompareLogic().Compare(expected, actualEmpty);

            // Assert

            Assert.IsTrue(comparisonResult.AreEqual);
        }

        [TestMethod]
        public void UpdateExistingNote_EnteredValueEmpty_ReturnsFalse()
        {
            // Arrange
            NoteService note = new NoteService();

            // Act

            var actualEmpty = note.UpdateNote("", "");
            var expected = new Result(false, "Fill up fields");
            var comparisonResult = new CompareLogic().Compare(expected, actualEmpty);

            // Assert

            Assert.IsTrue(comparisonResult.AreEqual);
        }

        [TestMethod]
        public void MoveNoteToCategory_EnteredValueEmpty_ReturnsFalse()
        {
            // Arrange
            NoteService note = new NoteService();
            string noteEmpty = "";
            string categoty = "";

            // Act

            var actualEmpty = note.MoveNoteToCategory(noteEmpty, categoty);
            var expected = new Result(false, $"{noteEmpty} to {categoty} Not Moved");
            var comparisonResult = new CompareLogic().Compare(expected, actualEmpty);

            // Assert

            Assert.IsTrue(comparisonResult.AreEqual);
        }

        [TestMethod]
        public void DeleteNote_EnteredValueEmpty_ReturnsFalse()
        {
            // Arrange
            NoteService note = new NoteService();

            // Act

            var actualEmpty = note.DeleteNote("", "");
            var expected = new Result(false, "Fill up fields");
            var comparisonResult = new CompareLogic().Compare(expected, actualEmpty);

            // Assert

            Assert.IsTrue(comparisonResult.AreEqual);
        }
    }
}
