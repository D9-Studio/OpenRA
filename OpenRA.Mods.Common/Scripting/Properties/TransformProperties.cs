#region Copyright & License Information
/*
 * Copyright (c) The OpenRA Developers and Contributors
 * This file is part of OpenRA, which is free software. It is made
 * available to you under the terms of the GNU General Public License
 * as published by the Free Software Foundation, either version 3 of
 * the License, or (at your option) any later version. For more
 * information, see COPYING.
 */
#endregion

using System.Linq;
using OpenRA.Mods.Common.Traits;
using OpenRA.Scripting;
using OpenRA.Traits;

namespace OpenRA.Mods.Common.Scripting
{
	[ScriptPropertyGroup("General")]
	public class TransformProperties : ScriptActorProperties, Requires<TransformsInfo>
	{
		readonly Actor self;

		public TransformProperties(ScriptContext context, Actor self)
			: base(context, self)
		{
			this.self = self;
		}

		[ScriptActorPropertyActivity]
		[Desc("Queue a new transformation.")]
		public void Deploy()
		{
			// Use the currently-enabled Transforms trait so actors with multiple
			// faction-conditional Transforms@ variants resolve correctly.
			var transforms = AIUtils.ActiveTransforms(self) ?? self.TraitsImplementing<Transforms>().FirstOrDefault();
			transforms?.DeployTransform(true);
		}
	}
}
