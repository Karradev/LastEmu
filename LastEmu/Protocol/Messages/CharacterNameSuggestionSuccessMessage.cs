using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class CharacterNameSuggestionSuccessMessage : NetworkMessage
	{
		public const uint Id = 5544;

		public string suggestion;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5544;
			}
		}

		public CharacterNameSuggestionSuccessMessage()
		{
		}

		public CharacterNameSuggestionSuccessMessage(string suggestion)
		{
			this.suggestion = suggestion;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.suggestion = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.suggestion);
		}
	}
}