using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class BasicWhoIsMessage : NetworkMessage
	{
		public const uint Id = 180;

		public bool self;

		public bool verbose;

		public sbyte position;

		public string accountNickname;

		public int accountId;

		public string playerName;

		public double playerId;

		public short areaId;

		public short serverId;

		public short originServerId;

		public AbstractSocialGroupInfos[] socialGroups;

		public sbyte playerState;

		public override uint ProtocolId
		{
			get
			{
				return (uint)180;
			}
		}

		public BasicWhoIsMessage()
		{
		}

		public BasicWhoIsMessage(bool self, bool verbose, sbyte position, string accountNickname, int accountId, string playerName, double playerId, short areaId, short serverId, short originServerId, AbstractSocialGroupInfos[] socialGroups, sbyte playerState)
		{
			this.self = self;
			this.verbose = verbose;
			this.position = position;
			this.accountNickname = accountNickname;
			this.accountId = accountId;
			this.playerName = playerName;
			this.playerId = playerId;
			this.areaId = areaId;
			this.serverId = serverId;
			this.originServerId = originServerId;
			this.socialGroups = socialGroups;
			this.playerState = playerState;
		}

		public override void Deserialize(IDataReader reader)
		{
			byte num = reader.ReadByte();
			this.self = BooleanByteWrapper.GetFlag(num, 0);
			this.verbose = BooleanByteWrapper.GetFlag(num, 1);
			this.position = reader.ReadSByte();
			this.accountNickname = reader.ReadUTF();
			this.accountId = reader.ReadInt();
			this.playerName = reader.ReadUTF();
			this.playerId = reader.ReadVarUhLong();
			this.areaId = reader.ReadShort();
			this.serverId = reader.ReadShort();
			this.originServerId = reader.ReadShort();
			ushort num1 = reader.ReadUShort();
			this.socialGroups = new AbstractSocialGroupInfos[num1];
			for (int i = 0; i < num1; i++)
			{
				this.socialGroups[i] = ProtocolTypeManager.GetInstance<AbstractSocialGroupInfos>(reader.ReadUShort());
				this.socialGroups[i].Deserialize(reader);
			}
			this.playerState = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			byte num = BooleanByteWrapper.SetFlag(0, 0, this.self);
			writer.WriteByte(BooleanByteWrapper.SetFlag(num, 1, this.verbose));
			writer.WriteSByte(this.position);
			writer.WriteUTF(this.accountNickname);
			writer.WriteInt(this.accountId);
			writer.WriteUTF(this.playerName);
			writer.WriteVarLong(this.playerId);
			writer.WriteShort(this.areaId);
			writer.WriteShort(this.serverId);
			writer.WriteShort(this.originServerId);
			writer.WriteShort((short)((int)this.socialGroups.Length));
			AbstractSocialGroupInfos[] abstractSocialGroupInfosArray = this.socialGroups;
			for (int i = 0; i < (int)abstractSocialGroupInfosArray.Length; i++)
			{
				AbstractSocialGroupInfos abstractSocialGroupInfo = abstractSocialGroupInfosArray[i];
				writer.WriteShort(abstractSocialGroupInfo.TypeId);
				abstractSocialGroupInfo.Serialize(writer);
			}
			writer.WriteSByte(this.playerState);
		}
	}
}