﻿using AdeNote.Models.DTOs;
using TasksLibrary.Utilities;

namespace AdeNote.Infrastructure.Services
{
    /// <summary>
    /// An interface to interact with the controller
    /// </summary>
    public interface ILabelService
    {
        /// <summary>
        /// Adds new label
        /// </summary>
        /// <param name="createLabel">An object used to create new object</param>
        /// <returns>Action result</returns>
        Task<ActionResult> Add(LabelCreateDTO createLabel);
        /// <summary>
        /// Updates an existing label
        /// </summary>
        /// <param name="labelId">label id</param>
        /// <param name="updateLabel">An object to update a label</param>
        /// <returns>Action result</returns>
        Task<ActionResult> Update(Guid labelId, LabelUpdateDTO updateLabel);

        /// <summary>
        /// Removes an existing label
        /// </summary>
        /// <param name="labelId">label id</param>
        /// <returns>Action result</returns>
        Task<ActionResult> Remove(Guid labelId);
        /// <summary>
        /// Gets a particular label by id
        /// </summary>
        /// <param name="labelId">label id</param>
        /// <returns>Action result</returns>
        Task<ActionResult<LabelDTO>> GetById(Guid labelId);
        /// <summary>
        /// Gets all the labels
        /// </summary>
        /// <returns>Action result</returns>
        Task<ActionResult<IEnumerable<LabelDTO>>> GetAll();
    }
}
