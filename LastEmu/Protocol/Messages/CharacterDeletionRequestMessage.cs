using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class CharacterDeletionRequestMessage : NetworkMessage
	{
		public const uint Id = 165;

		public double characterId;

		public string secretAnswerHash;

		public override uint ProtocolId
		{
			get
			{
				return (uint)165;
			}
		}

		public CharacterDeletionRequestMessage()
		{
		}

		public CharacterDeletionRequestMessage(double characterId, string secretAnswerHash)
		{
			this.characterId = characterId;
			this.secretAnswerHash = secretAnswerHash;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.characterId = reader.ReadVarUhLong();
			this.secretAnswerHash = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(this.characterId);
			writer.WriteUTF(this.secretAnswerHash);
		}
	}
}