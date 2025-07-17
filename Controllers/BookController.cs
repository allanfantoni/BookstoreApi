using BookstoreApi.Communication.Requests;
using BookstoreApi.Communication.Responses;
using BookstoreApi.Entities;
using BookstoreApi.Enums;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreApi.Controllers;

public class BookController : BookstoreApiBaseController
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredBookJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestRegisterBookJson request)
    {
        var response = new ResponseRegisteredBookJson
        {
            Id = 1,
            Title = request.Title
        };

        return Created(string.Empty, response);
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
    public IActionResult GetById([FromRoute] int id)
    {
        var response = new Book
        {
            Id = 1,
            Title = "Title 1",
            Author = "Author 1",
            Genre = Genre.Fiction,
            Price = 29.99m,
            Quantity = 30
        };

        if (response.Id == id)
            return Ok(response);
        else
            return NotFound($"Book with ID {id} not found.");
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = new List<Book>()
        {
            new Book
            {
                Id = 1,
                Title = "Title 1",
                Author = "Author 1",
                Genre = Genre.Fiction,
                Price = 29.99m,
                Quantity = 30
            },
            new Book
            {
                Id = 2,
                Title = "Title 2",
                Author = "Author 2",
                Genre = Genre.Drama,
                Price = 24.99m,
                Quantity = 20
            }
        };

        return Ok(response);
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromBody] RequestUpdateBookDetailJson request)
    {
        return NoContent();
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete()
    {
        return NoContent();
    }
}