using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GameRolePlayNamedActorInformations : GameRolePlayActorInformations
	{
		public const short Id = 154;

		public string name;

		public override short TypeId
		{
			get
			{
				return 154;
			}
		}

		public GameRolePlayNamedActorInformations()
		{
		}

		public GameRolePlayNamedActorInformations(double contextualId, EntityLook look, EntityDispositionInformations disposition, string name) : base(contextualId, look, disposition)
		{
			this.name = name;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.name = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(this.name);
		}
	}
}