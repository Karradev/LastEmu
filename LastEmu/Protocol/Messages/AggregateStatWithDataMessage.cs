using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class AggregateStatWithDataMessage : AggregateStatMessage
	{
		public const uint Id = 6662;

		public StatisticData[] datas;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6662;
			}
		}

		public AggregateStatWithDataMessage()
		{
		}

		public AggregateStatWithDataMessage(uint statId, StatisticData[] datas) : base(statId)
		{
			this.datas = datas;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ushort num = reader.ReadUShort();
			this.datas = new StatisticData[num];
			for (int i = 0; i < num; i++)
			{
				this.datas[i] = ProtocolTypeManager.GetInstance<StatisticData>(reader.ReadUShort());
				this.datas[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort((short)((int)this.datas.Length));
			StatisticData[] statisticDataArray = this.datas;
			for (int i = 0; i < (int)statisticDataArray.Length; i++)
			{
				StatisticData statisticDatum = statisticDataArray[i];
				writer.WriteShort(statisticDatum.TypeId);
				statisticDatum.Serialize(writer);
			}
		}
	}
}