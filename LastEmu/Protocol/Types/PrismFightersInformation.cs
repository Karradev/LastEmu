using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class PrismFightersInformation
	{
		public const short Id = 443;

		public uint subAreaId;

		public ProtectedEntityWaitingForHelpInfo waitingForHelpInfo;

		public CharacterMinimalPlusLookInformations[] allyCharactersInformations;

		public CharacterMinimalPlusLookInformations[] enemyCharactersInformations;

		public virtual short TypeId
		{
			get
			{
				return 443;
			}
		}

		public PrismFightersInformation()
		{
		}

		public PrismFightersInformation(uint subAreaId, ProtectedEntityWaitingForHelpInfo waitingForHelpInfo, CharacterMinimalPlusLookInformations[] allyCharactersInformations, CharacterMinimalPlusLookInformations[] enemyCharactersInformations)
		{
			this.subAreaId = subAreaId;
			this.waitingForHelpInfo = waitingForHelpInfo;
			this.allyCharactersInformations = allyCharactersInformations;
			this.enemyCharactersInformations = enemyCharactersInformations;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.subAreaId = reader.ReadVarUhShort();
			this.waitingForHelpInfo = new ProtectedEntityWaitingForHelpInfo();
			this.waitingForHelpInfo.Deserialize(reader);
			ushort num = reader.ReadUShort();
			this.allyCharactersInformations = new CharacterMinimalPlusLookInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.allyCharactersInformations[i] = ProtocolTypeManager.GetInstance<CharacterMinimalPlusLookInformations>(reader.ReadUShort());
				this.allyCharactersInformations[i].Deserialize(reader);
			}
			num = reader.ReadUShort();
			this.enemyCharactersInformations = new CharacterMinimalPlusLookInformations[num];
			for (int j = 0; j < num; j++)
			{
				this.enemyCharactersInformations[j] = ProtocolTypeManager.GetInstance<CharacterMinimalPlusLookInformations>(reader.ReadUShort());
				this.enemyCharactersInformations[j].Deserialize(reader);
			}
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.subAreaId);
			this.waitingForHelpInfo.Serialize(writer);
			writer.WriteShort((short)((int)this.allyCharactersInformations.Length));
			CharacterMinimalPlusLookInformations[] characterMinimalPlusLookInformationsArray = this.allyCharactersInformations;
			for (int i = 0; i < (int)characterMinimalPlusLookInformationsArray.Length; i++)
			{
				CharacterMinimalPlusLookInformations characterMinimalPlusLookInformation = characterMinimalPlusLookInformationsArray[i];
				writer.WriteShort(characterMinimalPlusLookInformation.TypeId);
				characterMinimalPlusLookInformation.Serialize(writer);
			}
			writer.WriteShort((short)((int)this.enemyCharactersInformations.Length));
			CharacterMinimalPlusLookInformations[] characterMinimalPlusLookInformationsArray1 = this.enemyCharactersInformations;
			for (int j = 0; j < (int)characterMinimalPlusLookInformationsArray1.Length; j++)
			{
				CharacterMinimalPlusLookInformations characterMinimalPlusLookInformation1 = characterMinimalPlusLookInformationsArray1[j];
				writer.WriteShort(characterMinimalPlusLookInformation1.TypeId);
				characterMinimalPlusLookInformation1.Serialize(writer);
			}
		}
	}
}