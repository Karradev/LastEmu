using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class CharacterSelectionMessage : NetworkMessage
	{
		public const uint Id = 152;

		public double id;

		public override uint ProtocolId
		{
			get
			{
				return (uint)152;
			}
		}

		public CharacterSelectionMessage()
		{
		}

		public CharacterSelectionMessage(double id)
		{
			this.id = id;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.id = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(this.id);
		}
	}
}