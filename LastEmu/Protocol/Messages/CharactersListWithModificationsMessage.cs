using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class CharactersListWithModificationsMessage : CharactersListMessage
	{
		public const uint Id = 6120;

		public CharacterToRecolorInformation[] charactersToRecolor;

		public int[] charactersToRename;

		public int[] unusableCharacters;

		public CharacterToRelookInformation[] charactersToRelook;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6120;
			}
		}

		public CharactersListWithModificationsMessage()
		{
		}

		public CharactersListWithModificationsMessage(CharacterBaseInformations[] characters, bool hasStartupActions, CharacterToRecolorInformation[] charactersToRecolor, int[] charactersToRename, int[] unusableCharacters, CharacterToRelookInformation[] charactersToRelook) : base(characters, hasStartupActions)
		{
			this.charactersToRecolor = charactersToRecolor;
			this.charactersToRename = charactersToRename;
			this.unusableCharacters = unusableCharacters;
			this.charactersToRelook = charactersToRelook;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ushort num = reader.ReadUShort();
			this.charactersToRecolor = new CharacterToRecolorInformation[num];
			for (int i = 0; i < num; i++)
			{
				this.charactersToRecolor[i] = new CharacterToRecolorInformation();
				this.charactersToRecolor[i].Deserialize(reader);
			}
			num = reader.ReadUShort();
			this.charactersToRename = new int[num];
			for (int j = 0; j < num; j++)
			{
				this.charactersToRename[j] = reader.ReadInt();
			}
			num = reader.ReadUShort();
			this.unusableCharacters = new int[num];
			for (int k = 0; k < num; k++)
			{
				this.unusableCharacters[k] = reader.ReadInt();
			}
			num = reader.ReadUShort();
			this.charactersToRelook = new CharacterToRelookInformation[num];
			for (int l = 0; l < num; l++)
			{
				this.charactersToRelook[l] = new CharacterToRelookInformation();
				this.charactersToRelook[l].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort((short)((int)this.charactersToRecolor.Length));
			CharacterToRecolorInformation[] characterToRecolorInformationArray = this.charactersToRecolor;
			for (int i = 0; i < (int)characterToRecolorInformationArray.Length; i++)
			{
				characterToRecolorInformationArray[i].Serialize(writer);
			}
			writer.WriteShort((short)((int)this.charactersToRename.Length));
			int[] numArray = this.charactersToRename;
			for (int j = 0; j < (int)numArray.Length; j++)
			{
				writer.WriteInt(numArray[j]);
			}
			writer.WriteShort((short)((int)this.unusableCharacters.Length));
			int[] numArray1 = this.unusableCharacters;
			for (int k = 0; k < (int)numArray1.Length; k++)
			{
				writer.WriteInt(numArray1[k]);
			}
			writer.WriteShort((short)((int)this.charactersToRelook.Length));
			CharacterToRelookInformation[] characterToRelookInformationArray = this.charactersToRelook;
			for (int l = 0; l < (int)characterToRelookInformationArray.Length; l++)
			{
				characterToRelookInformationArray[l].Serialize(writer);
			}
		}
	}
}