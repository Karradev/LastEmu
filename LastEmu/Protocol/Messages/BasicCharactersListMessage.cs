using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class BasicCharactersListMessage : NetworkMessage
	{
		public const uint Id = 6475;

		public CharacterBaseInformations[] characters;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6475;
			}
		}

		public BasicCharactersListMessage()
		{
		}

		public BasicCharactersListMessage(CharacterBaseInformations[] characters)
		{
			this.characters = characters;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.characters = new CharacterBaseInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.characters[i] = ProtocolTypeManager.GetInstance<CharacterBaseInformations>(reader.ReadUShort());
				this.characters[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.characters.Length));
			CharacterBaseInformations[] characterBaseInformationsArray = this.characters;
			for (int i = 0; i < (int)characterBaseInformationsArray.Length; i++)
			{
				CharacterBaseInformations characterBaseInformation = characterBaseInformationsArray[i];
				writer.WriteShort(characterBaseInformation.TypeId);
				characterBaseInformation.Serialize(writer);
			}
		}
	}
}