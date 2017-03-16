using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class CharactersListWithRemodelingMessage : CharactersListMessage
	{
		public const uint Id = 6550;

		public CharacterToRemodelInformations[] charactersToRemodel;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6550;
			}
		}

		public CharactersListWithRemodelingMessage()
		{
		}

		public CharactersListWithRemodelingMessage(CharacterBaseInformations[] characters, bool hasStartupActions, CharacterToRemodelInformations[] charactersToRemodel) : base(characters, hasStartupActions)
		{
			this.charactersToRemodel = charactersToRemodel;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ushort num = reader.ReadUShort();
			this.charactersToRemodel = new CharacterToRemodelInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.charactersToRemodel[i] = new CharacterToRemodelInformations();
				this.charactersToRemodel[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort((short)((int)this.charactersToRemodel.Length));
			CharacterToRemodelInformations[] characterToRemodelInformationsArray = this.charactersToRemodel;
			for (int i = 0; i < (int)characterToRemodelInformationsArray.Length; i++)
			{
				characterToRemodelInformationsArray[i].Serialize(writer);
			}
		}
	}
}