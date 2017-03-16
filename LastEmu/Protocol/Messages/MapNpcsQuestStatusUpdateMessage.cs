using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class MapNpcsQuestStatusUpdateMessage : NetworkMessage
	{
		public const uint Id = 5642;

		public int mapId;

		public int[] npcsIdsWithQuest;

		public GameRolePlayNpcQuestFlag[] questFlags;

		public int[] npcsIdsWithoutQuest;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5642;
			}
		}

		public MapNpcsQuestStatusUpdateMessage()
		{
		}

		public MapNpcsQuestStatusUpdateMessage(int mapId, int[] npcsIdsWithQuest, GameRolePlayNpcQuestFlag[] questFlags, int[] npcsIdsWithoutQuest)
		{
			this.mapId = mapId;
			this.npcsIdsWithQuest = npcsIdsWithQuest;
			this.questFlags = questFlags;
			this.npcsIdsWithoutQuest = npcsIdsWithoutQuest;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.mapId = reader.ReadInt();
			ushort num = reader.ReadUShort();
			this.npcsIdsWithQuest = new int[num];
			for (int i = 0; i < num; i++)
			{
				this.npcsIdsWithQuest[i] = reader.ReadInt();
			}
			num = reader.ReadUShort();
			this.questFlags = new GameRolePlayNpcQuestFlag[num];
			for (int j = 0; j < num; j++)
			{
				this.questFlags[j] = new GameRolePlayNpcQuestFlag();
				this.questFlags[j].Deserialize(reader);
			}
			num = reader.ReadUShort();
			this.npcsIdsWithoutQuest = new int[num];
			for (int k = 0; k < num; k++)
			{
				this.npcsIdsWithoutQuest[k] = reader.ReadInt();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.mapId);
			writer.WriteShort((short)((int)this.npcsIdsWithQuest.Length));
			int[] numArray = this.npcsIdsWithQuest;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteInt(numArray[i]);
			}
			writer.WriteShort((short)((int)this.questFlags.Length));
			GameRolePlayNpcQuestFlag[] gameRolePlayNpcQuestFlagArray = this.questFlags;
			for (int j = 0; j < (int)gameRolePlayNpcQuestFlagArray.Length; j++)
			{
				gameRolePlayNpcQuestFlagArray[j].Serialize(writer);
			}
			writer.WriteShort((short)((int)this.npcsIdsWithoutQuest.Length));
			int[] numArray1 = this.npcsIdsWithoutQuest;
			for (int k = 0; k < (int)numArray1.Length; k++)
			{
				writer.WriteInt(numArray1[k]);
			}
		}
	}
}