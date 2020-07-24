﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Altairis.Fakturoid.Client {
    /// <summary>
    /// Proxy class for working with subjects/contacts.
    /// </summary>
    public class FakturoidSubjectsProxy : FakturoidEntityProxy {

        internal FakturoidSubjectsProxy(FakturoidContext context) : base(context) { }

        /// <summary>
        /// Gets list of all subjects.
        /// </summary>
        /// <param name="customId">The custom identifier used for filtering.</param>
        /// <returns>
        /// List of <see cref="JsonSubject" /> instances.
        /// </returns>
        public IEnumerable<JsonSubject> Select(string customId = null) => base.GetAllPagedEntities<JsonSubject>("subjects.json", new { custom_id = customId });

        /// <summary>
        /// Gets asynchronously list of all subjects.
        /// </summary>
        /// <param name="customId">The custom identifier used for filtering.</param>
        /// <returns>
        /// List of <see cref="JsonSubject" /> instances.
        /// </returns>
        public async Task<IEnumerable<JsonSubject>> SelectAsync(string customId = null) => await base.GetAllPagedEntitiesAsync<JsonSubject>("subjects.json", new { custom_id = customId });

        /// <summary>
        /// Gets paged list of subjects
        /// </summary>
        /// <param name="page">The page number.</param>
        /// <returns>List of <see cref="JsonSubject"/> instances.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">page;Value must be greater than zero.</exception>
        public IEnumerable<JsonSubject> Select(int page) {
            if (page < 1) throw new ArgumentOutOfRangeException(nameof(page), "Value must be greater than zero.");
            return base.GetPagedEntities<JsonSubject>("subjects.json", page);
        }

        /// <summary>
        /// Gets asynchronously paged list of subjects
        /// </summary>
        /// <param name="page">The page number.</param>
        /// <returns>List of <see cref="JsonSubject"/> instances.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">page;Value must be greater than zero.</exception>
        public async Task<IEnumerable<JsonSubject>> SelectAsync(int page) {
            if (page < 1) throw new ArgumentOutOfRangeException(nameof(page), "Value must be greater than zero.");
            return await base.GetPagedEntitiesAsync<JsonSubject>("subjects.json", page);
        }

        /// <summary>
        /// Selects single subject with specified ID.
        /// </summary>
        /// <param name="id">The subject id.</param>
        /// <returns>Instance of <see cref="JsonSubject"/> class.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">id;Value must be greater than zero.</exception>
        public JsonSubject SelectSingle(int id) {
            if (id < 1) throw new ArgumentOutOfRangeException(nameof(id), "Value must be greater than zero.");

            return base.GetSingleEntity<JsonSubject>(string.Format("subjects/{0}.json", id));
        }

        /// <summary>
        /// Selects asynchronously single subject with specified ID.
        /// </summary>
        /// <param name="id">The subject id.</param>
        /// <returns>Instance of <see cref="JsonSubject"/> class.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">id;Value must be greater than zero.</exception>
        public async Task<JsonSubject> SelectSingleAsync(int id) {
            if (id < 1) throw new ArgumentOutOfRangeException(nameof(id), "Value must be greater than zero.");

            return await base.GetSingleEntityAsync<JsonSubject>(string.Format("subjects/{0}.json", id));
        }

        /// <summary>
        /// Deletes subject with specified id.
        /// </summary>
        /// <param name="id">The contact id.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">id;Value must be greater than zero.</exception>
        public void Delete(int id) {
            if (id < 1) throw new ArgumentOutOfRangeException(nameof(id), "Value must be greater than zero.");

            base.DeleteSingleEntity(string.Format("subjects/{0}.json", id));
        }

        /// <summary>
        /// Deletes asynchronously with specified id.
        /// </summary>
        /// <param name="id">The contact id.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">id;Value must be greater than zero.</exception>
        public async Task DeleteAsync(int id) {
            if (id < 1) throw new ArgumentOutOfRangeException(nameof(id), "Value must be greater than zero.");

            await base.DeleteSingleEntityAsync(string.Format("subjects/{0}.json", id));
        }

        /// <summary>
        /// Creates the specified new subject.
        /// </summary>
        /// <param name="entity">The new subject.</param>
        /// <returns>ID of newly created subject.</returns>
        /// <exception cref="ArgumentNullException">entity</exception>
        public int Create(JsonSubject entity) {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            return base.CreateEntity("subjects.json", entity);
        }

        /// <summary>
        /// Creates asynchronously the specified new subject.
        /// </summary>
        /// <param name="entity">The new subject.</param>
        /// <returns>ID of newly created subject.</returns>
        /// <exception cref="ArgumentNullException">entity</exception>
        public async Task<int> CreateAsync(JsonSubject entity) {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            return await base.CreateEntityAsync("subjects.json", entity);
        }

        /// <summary>
        /// Updates the specified subject.
        /// </summary>
        /// <param name="entity">The subject to update.</param>
        /// <returns>Instance of <see cref="JsonSubject"/> class with modified entity.</returns>
        /// <exception cref="ArgumentNullException">entity</exception>
        public JsonSubject Update(JsonSubject entity) {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            return base.UpdateSingleEntity(string.Format("subjects/{0}.json", entity.id), entity);
        }

        /// <summary>
        /// Updates asynchronously the specified subject.
        /// </summary>
        /// <param name="entity">The subject to update.</param>
        /// <returns>Instance of <see cref="JsonSubject"/> class with modified entity.</returns>
        /// <exception cref="ArgumentNullException">entity</exception>
        public async Task<JsonSubject> UpdateAsync(JsonSubject entity) {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            return await base.UpdateSingleEntityAsync(string.Format("subjects/{0}.json", entity.id), entity);
        }
        
        /// <summary>Gets list of all subjects matching query.</summary>
        /// <param name="query">The query used to search subject.</param>
        /// <returns>
        /// List of <see cref="T:Altairis.Fakturoid.Client.JsonSubject" /> instances.
        /// </returns>
        public IEnumerable<JsonSubject> Search(string query = null)
        {
            return this.GetAllPagedEntities<JsonSubject>("subjects/search.json", (object) new
            {
                query = query
            });
        }

        /// <summary>Gets list of all subjects matching query.</summary>
        /// <param name="query">The query used to search subject.</param>
        /// <returns>
        /// List of <see cref="T:Altairis.Fakturoid.Client.JsonSubject" /> instances.
        /// </returns>
        public async Task<IEnumerable<JsonSubject>> SearchAsync(
            string query = null)
        {
            IEnumerable<JsonSubject> pagedEntitiesAsync = await this.GetAllPagedEntitiesAsync<JsonSubject>(
                "subjects/search.json", (object) new
                {
                    query = query
                });
            return pagedEntitiesAsync;
        }
    }
}
