using UnityEngine;
using helloworld.config;
using helloworld.views;
using robotlegs.bender.bundles;
using robotlegs.bender.extensions.eventDispatcher.api;
using robotlegs.bender.framework.api;
using robotlegs.bender.framework.impl;
using robotlegs.bender.platforms.unity.extensions.contextview.impl;

namespace helloworld
{
	public class HelloWorld : MonoBehaviour
	{
		IContext context;

		public void Start()
		{
			context = new Context ();
			context.Install<UnityMVCSBundle> ()
				.Install<UnityFallbackBundle>()
				.Configure<HelloWorldConfig> ()
				.Configure (new TransformContextView (this.transform));
		}
	}
}
