using EasyCaching.Core.Serialization;
using EasyCaching.Serialization.MemoryPack;
using Microsoft.Extensions.DependencyInjection;

//===== Reproduce the root cause =====
//NET6Project.Class1.SetInitProperty();

var services = new ServiceCollection();

services.AddEasyCaching(options => options.WithMemoryPack());

var provider = services.BuildServiceProvider();

var serializer = provider.GetRequiredService<IEasyCachingSerializer>();
//Throws => System.MissingMethodException: Method not found: 'Void MemoryPack.MemoryPackSerializerOptions.set_StringEncoding(MemoryPack.StringEncoding)'.

Console.WriteLine("Finished Successfully");