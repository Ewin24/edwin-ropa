// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using API.Controllers;
// using API.Dtos;
// using AutoMapper;
// using Core.Entities;
// using Core.Interfaces;
// using Infrastructure.Data;
// using Microsoft.AspNetCore.Mvc;

// namespace API.Controllers
// {
//     public class TipoEstadoController : BaseController
//     {
//         private readonly IUnityOfWork _UnitOfWork;
//         private readonly IMapper _mapper;

//         public TipoEstadoController(IUnityOfWork unitOfWork, IMapper mapper){
//             _UnitOfWork = unitOfWork;
//             _mapper = mapper;
//         }

//         [HttpGet]
//         [ProducesResponseType(StatusCodes.Status200OK)]
//         [ProducesResponseType(StatusCodes.Status400BadRequest)]

//         public async Task<ActionResult<IEnumerable<TipoEstado>>> Get(){
//             var items = await _UnitOfWork.TipoEstado.GetAllAsync();
//             return Ok(items);
//         }

//         [HttpGet("{id}")]
//         [ProducesResponseType(StatusCodes.Status200OK)]
//         [ProducesResponseType(StatusCodes.Status400BadRequest)]
//         [ProducesResponseType(StatusCodes.Status404NotFound)]

//         public async Task<ActionResult<IEnumerable<TipoEstado>>> Get(int id){
//             var item = await _UnitOfWork.TipoEstado.GetByIdAsync(id);
//             return Ok(item); 
//         }

//         [HttpPost]
//         [ProducesResponseType(StatusCodes.Status200OK)]
//         [ProducesResponseType(StatusCodes.Status400BadRequest)]
//         [ProducesResponseType(StatusCodes.Status404NotFound)]

//         public async Task<ActionResult<TipoEstado>> Post(TipoEstadoDto itemDto){
//             var item = _mapper.Map<TipoEstado>(itemDto);
//             this._UnitOfWork.TipoEstado.Add(item);
//             await _UnitOfWork.SaveAsync();
//             if (item==null){
//                 return BadRequest();
//             }
//             return CreatedAtAction(nameof(Post), new { id = item.Id }, item);
//         }

//         [HttpPut("{id}")]
//         [ProducesResponseType(StatusCodes.Status200OK)]
//         [ProducesResponseType(StatusCodes.Status400BadRequest)]
//         [ProducesResponseType(StatusCodes.Status404NotFound)]

//         public async Task<ActionResult<TipoEstado>> Put(int id, [FromBody] TipoEstado item){
//             if (item.Id == 0){
//                 item.Id=id;
//             }
//             if (item.Id != id){
//                 return BadRequest();
//             }
//             if (item == null){
//                 return NotFound();
//             }
//             _UnitOfWork.TipoEstado.Update(item);
//             await _UnitOfWork.SaveAsync();
//             return item;
//         }
//         [HttpDelete("{id}")]
//         [ProducesResponseType(StatusCodes.Status204NoContent)]
//         [ProducesResponseType(StatusCodes.Status404NotFound)]
//         public async Task<ActionResult> Delete(int id){
//             var item = await _UnitOfWork.TipoEstado.GetByIdAsync(id);
//             if (item == null){
//                 return NotFound();
//             }
//             _UnitOfWork.TipoEstado.Delete(item);
//             await _UnitOfWork.SaveAsync();
//             return NoContent();
//         }
//     }
// }