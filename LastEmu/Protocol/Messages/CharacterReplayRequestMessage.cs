using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class CharacterReplayRequestMessage : NetworkMessage
	{
		public const uint Id = 167;

		public double characterId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)167;
			}
		}

		public CharacterReplayRequestMessage()
		{
		}

		public CharacterReplayRequestMessage(double characterId)
		{
			this.characterId = characterId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.characterId = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(this.characterId);
		}
	}
}