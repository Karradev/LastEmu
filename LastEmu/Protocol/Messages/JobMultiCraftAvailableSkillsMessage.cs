using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class JobMultiCraftAvailableSkillsMessage : JobAllowMultiCraftRequestMessage
	{
		public const uint Id = 5747;

		public double playerId;

		public uint[] skills;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5747;
			}
		}

		public JobMultiCraftAvailableSkillsMessage()
		{
		}

		public JobMultiCraftAvailableSkillsMessage(bool enabled, double playerId, uint[] skills) : base(enabled)
		{
			this.playerId = playerId;
			this.skills = skills;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.playerId = reader.ReadVarUhLong();
			ushort num = reader.ReadUShort();
			this.skills = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.skills[i] = reader.ReadVarUhShort();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(this.playerId);
			writer.WriteShort((short)((int)this.skills.Length));
			uint[] numArray = this.skills;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarShort((int)numArray[i]);
			}
		}
	}
}