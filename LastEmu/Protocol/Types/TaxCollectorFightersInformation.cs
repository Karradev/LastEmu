using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class TaxCollectorFightersInformation
	{
		public const short Id = 169;

		public int collectorId;

		public CharacterMinimalPlusLookInformations[] allyCharactersInformations;

		public CharacterMinimalPlusLookInformations[] enemyCharactersInformations;

		public virtual short TypeId
		{
			get
			{
				return 169;
			}
		}

		public TaxCollectorFightersInformation()
		{
		}

		public TaxCollectorFightersInformation(int collectorId, CharacterMinimalPlusLookInformations[] allyCharactersInformations, CharacterMinimalPlusLookInformations[] enemyCharactersInformations)
		{
			this.collectorId = collectorId;
			this.allyCharactersInformations = allyCharactersInformations;
			this.enemyCharactersInformations = enemyCharactersInformations;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.collectorId = reader.ReadInt();
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
			writer.WriteInt(this.collectorId);
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