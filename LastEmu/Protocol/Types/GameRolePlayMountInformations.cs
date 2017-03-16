using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GameRolePlayMountInformations : GameRolePlayNamedActorInformations
	{
		public const short Id = 180;

		public string ownerName;

		public byte level;

		public override short TypeId
		{
			get
			{
				return 180;
			}
		}

		public GameRolePlayMountInformations()
		{
		}

		public GameRolePlayMountInformations(double contextualId, EntityLook look, EntityDispositionInformations disposition, string name, string ownerName, byte level) : base(contextualId, look, disposition, name)
		{
			this.ownerName = ownerName;
			this.level = level;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.ownerName = reader.ReadUTF();
			this.level = reader.ReadByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(this.ownerName);
			writer.WriteByte(this.level);
		}
	}
}