using System;
using System.Collections.Generic;

public static class ServiceLocator
{
	private readonly static Dictionary<Type, object> _services = new();

	public static void Register<T>(T service) where T : class => _services[typeof(T)] = service;
	public static void Unregister<T>() where T : class => _services.Remove(typeof(T));

	public static T Get<T>() where T : class
	{
		if (_services.TryGetValue(typeof(T), out object service)) return service as T;

		throw new Exception($"Service {typeof(T).Name} not found. Make sure all services" +
			" are registered before accessing through the service locator.");
	}
}
