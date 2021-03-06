#region License
// 
// Author: Nate Kohari <nate@enkari.com>
// Copyright (c) 2007-2009, Enkari, Ltd.
// 
// Dual-licensed under the Apache License, Version 2.0, and the Microsoft Public License (Ms-PL).
// See the file LICENSE.txt for details.
// 
#endregion
#region Using Directives
using System;
using Ninject.Components;
#endregion

namespace Ninject.Activation.Caching
{
	/// <summary>
	/// Tracks instances for re-use in certain scopes.
	/// </summary>
	public interface ICache : INinjectComponent
	{
		/// <summary>
		/// Stores the specified context in the cache.
		/// </summary>
		/// <param name="context">The context to store.</param>
		void Remember(IContext context);

		/// <summary>
		/// Tries to retrieve an instance to re-use in the specified context.
		/// </summary>
		/// <param name="context">The context that is being activated.</param>
		/// <returns>The instance for re-use, or <see langword="null"/> if none has been stored.</returns>
		object TryGet(IContext context);

		/// <summary>
		/// Removes instances from the cache which should no longer be re-used.
		/// </summary>
		void Prune();

		/// <summary>
		/// Immediately deactivates and removes all instances in the cache, regardless of scope.
		/// </summary>
		void Clear();
	}
}