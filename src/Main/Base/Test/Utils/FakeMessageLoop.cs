﻿// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;
using System.Threading;
using System.Threading.Tasks;

namespace ICSharpCode.SharpDevelop
{
	/// <summary>
	/// A fake message lop that always has <c>InvokeRequired=false</c> and synchronously invokes
	/// the callback passed to <c>InvokeIfRequired</c>.
	/// </summary>
	public class FakeMessageLoop : IMessageLoop
	{
		public Thread Thread {
			get {
				throw new NotImplementedException();
			}
		}
		
		public System.Windows.Threading.Dispatcher Dispatcher {
			get {
				throw new NotImplementedException();
			}
		}
		
		public SynchronizationContext SynchronizationContext {
			get {
				throw new NotImplementedException();
			}
		}
		
		public System.ComponentModel.ISynchronizeInvoke SynchronizingObject {
			get {
				throw new NotImplementedException();
			}
		}
		
		public bool InvokeRequired {
			get { return false; }
		}
		
		public bool CheckAccess()
		{
			return true;
		}
		
		public void VerifyAccess()
		{
		}
		
		public void InvokeIfRequired(Action callback)
		{
			callback();
		}
		
		public void InvokeIfRequired(Action callback, System.Windows.Threading.DispatcherPriority priority)
		{
			callback();
		}
		
		public void InvokeIfRequired(Action callback, System.Windows.Threading.DispatcherPriority priority, CancellationToken cancellationToken)
		{
			callback();
		}
		
		public T InvokeIfRequired<T>(Func<T> callback)
		{
			return callback();
		}
		
		public T InvokeIfRequired<T>(Func<T> callback, System.Windows.Threading.DispatcherPriority priority)
		{
			return callback();
		}
		
		public T InvokeIfRequired<T>(Func<T> callback, System.Windows.Threading.DispatcherPriority priority, CancellationToken cancellationToken)
		{
			return callback();
		}
		
		public Task InvokeAsync(Action callback)
		{
			throw new NotImplementedException();
		}
		
		public Task InvokeAsync(Action callback, System.Windows.Threading.DispatcherPriority priority)
		{
			throw new NotImplementedException();
		}
		
		public Task InvokeAsync(Action callback, System.Windows.Threading.DispatcherPriority priority, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
		
		public Task<T> InvokeAsync<T>(Func<T> callback)
		{
			throw new NotImplementedException();
		}
		
		public Task<T> InvokeAsync<T>(Func<T> callback, System.Windows.Threading.DispatcherPriority priority)
		{
			throw new NotImplementedException();
		}
		
		public Task<T> InvokeAsync<T>(Func<T> callback, System.Windows.Threading.DispatcherPriority priority, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
		
		public void CallLater(TimeSpan delay, Action method)
		{
			throw new NotImplementedException();
		}
	}
}
