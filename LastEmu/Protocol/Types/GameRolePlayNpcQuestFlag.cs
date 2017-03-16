using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GameRolePlayNpcQuestFlag
	{
		public const short Id = 384;

		public uint[] questsToValidId;

		public uint[] questsToStartId;

		public virtual short TypeId
		{
			get
			{
				return 384;
			}
		}

		public GameRolePlayNpcQuestFlag()
		{
		}

		public GameRolePlayNpcQuestFlag(uint[] questsToValidId, uint[] questsToStartId)
		{
			this.questsToValidId = questsToValidId;
			this.questsToStartId = questsToStartId;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.questsToValidId = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.questsToValidId[i] = reader.ReadVarUhShort();
			}
			num = reader.ReadUShort();
			this.questsToStartId = new uint[num];
			for (int j = 0; j < num; j++)
			{
				this.questsToStartId[j] = reader.ReadVarUhShort();
			}
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.questsToValidId.Length));
			uint[] numArray = this.questsToValidId;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarShort((int)numArray[i]);
			}
			writer.WriteShort((short)((int)this.questsToStartId.Length));
			uint[] numArray1 = this.questsToStartId;
			for (int j = 0; j < (int)numArray1.Length; j++)
			{
				writer.WriteVarShort((int)numArray1[j]);
			}
		}
	}
}