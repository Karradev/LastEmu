using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GameRolePlayActorInformations : GameContextActorInformations
	{
		public const short Id = 141;

		public override short TypeId
		{
			get
			{
				return 141;
			}
		}

		public GameRolePlayActorInformations()
		{
		}

		public GameRolePlayActorInformations(double contextualId, EntityLook look, EntityDispositionInformations disposition) : base(contextualId, look, disposition)
		{
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
		}
	}
}