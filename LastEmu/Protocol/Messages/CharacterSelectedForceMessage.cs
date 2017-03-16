using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class CharacterSelectedForceMessage : NetworkMessage
	{
		public const uint Id = 6068;

		public int id;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6068;
			}
		}

		public CharacterSelectedForceMessage()
		{
		}

		public CharacterSelectedForceMessage(int id)
		{
			this.id = id;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.id = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.id);
		}
	}
}